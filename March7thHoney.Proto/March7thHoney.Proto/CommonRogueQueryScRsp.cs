using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CommonRogueQueryScRsp : IMessage<CommonRogueQueryScRsp>, IMessage, IEquatable<CommonRogueQueryScRsp>, IDeepCloneable<CommonRogueQueryScRsp>, IBufferMessage
{
	private static readonly MessageParser<CommonRogueQueryScRsp> _parser = new MessageParser<CommonRogueQueryScRsp>(() => new CommonRogueQueryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int NCCLCHDDKDFFieldNumber = 4;

	private uint nCCLCHDDKDF_;

	public const int RogueGetInfoFieldNumber = 12;

	private static readonly FieldCodec<GOFFIDNICKJ> _repeated_rogueGetInfo_codec = FieldCodec.ForMessage(98u, GOFFIDNICKJ.Parser);

	private readonly RepeatedField<GOFFIDNICKJ> rogueGetInfo_ = new RepeatedField<GOFFIDNICKJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CommonRogueQueryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CommonRogueQueryScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCCLCHDDKDF
	{
		get
		{
			return nCCLCHDDKDF_;
		}
		set
		{
			nCCLCHDDKDF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GOFFIDNICKJ> RogueGetInfo => rogueGetInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonRogueQueryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonRogueQueryScRsp(CommonRogueQueryScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		nCCLCHDDKDF_ = other.nCCLCHDDKDF_;
		rogueGetInfo_ = other.rogueGetInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonRogueQueryScRsp Clone()
	{
		return new CommonRogueQueryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CommonRogueQueryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CommonRogueQueryScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (NCCLCHDDKDF != other.NCCLCHDDKDF)
		{
			return false;
		}
		if (!rogueGetInfo_.Equals(other.rogueGetInfo_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (NCCLCHDDKDF != 0)
		{
			num ^= NCCLCHDDKDF.GetHashCode();
		}
		num ^= rogueGetInfo_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (NCCLCHDDKDF != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NCCLCHDDKDF);
		}
		rogueGetInfo_.WriteTo(ref output, _repeated_rogueGetInfo_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (NCCLCHDDKDF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCCLCHDDKDF);
		}
		num += rogueGetInfo_.CalculateSize(_repeated_rogueGetInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CommonRogueQueryScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.NCCLCHDDKDF != 0)
			{
				NCCLCHDDKDF = other.NCCLCHDDKDF;
			}
			rogueGetInfo_.Add(other.rogueGetInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 32u:
				NCCLCHDDKDF = input.ReadUInt32();
				break;
			case 98u:
				rogueGetInfo_.AddEntriesFrom(ref input, _repeated_rogueGetInfo_codec);
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetChessRogueNousStoryInfoScRsp : IMessage<GetChessRogueNousStoryInfoScRsp>, IMessage, IEquatable<GetChessRogueNousStoryInfoScRsp>, IDeepCloneable<GetChessRogueNousStoryInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetChessRogueNousStoryInfoScRsp> _parser = new MessageParser<GetChessRogueNousStoryInfoScRsp>(() => new GetChessRogueNousStoryInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int OLHNBEPHHFGFieldNumber = 10;

	private static readonly FieldCodec<CACLDCAFCKH> _repeated_oLHNBEPHHFG_codec = FieldCodec.ForMessage(82u, CACLDCAFCKH.Parser);

	private readonly RepeatedField<CACLDCAFCKH> oLHNBEPHHFG_ = new RepeatedField<CACLDCAFCKH>();

	public const int DOKHDOGAPKDFieldNumber = 11;

	private static readonly FieldCodec<DHGPCPMIFDC> _repeated_dOKHDOGAPKD_codec = FieldCodec.ForMessage(90u, DHGPCPMIFDC.Parser);

	private readonly RepeatedField<DHGPCPMIFDC> dOKHDOGAPKD_ = new RepeatedField<DHGPCPMIFDC>();

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetChessRogueNousStoryInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetChessRogueNousStoryInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CACLDCAFCKH> OLHNBEPHHFG => oLHNBEPHHFG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DHGPCPMIFDC> DOKHDOGAPKD => dOKHDOGAPKD_;

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
	public GetChessRogueNousStoryInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChessRogueNousStoryInfoScRsp(GetChessRogueNousStoryInfoScRsp other)
		: this()
	{
		oLHNBEPHHFG_ = other.oLHNBEPHHFG_.Clone();
		dOKHDOGAPKD_ = other.dOKHDOGAPKD_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChessRogueNousStoryInfoScRsp Clone()
	{
		return new GetChessRogueNousStoryInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetChessRogueNousStoryInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetChessRogueNousStoryInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oLHNBEPHHFG_.Equals(other.oLHNBEPHHFG_))
		{
			return false;
		}
		if (!dOKHDOGAPKD_.Equals(other.dOKHDOGAPKD_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= oLHNBEPHHFG_.GetHashCode();
		num ^= dOKHDOGAPKD_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
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
		oLHNBEPHHFG_.WriteTo(ref output, _repeated_oLHNBEPHHFG_codec);
		dOKHDOGAPKD_.WriteTo(ref output, _repeated_dOKHDOGAPKD_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
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
		num += oLHNBEPHHFG_.CalculateSize(_repeated_oLHNBEPHHFG_codec);
		num += dOKHDOGAPKD_.CalculateSize(_repeated_dOKHDOGAPKD_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetChessRogueNousStoryInfoScRsp other)
	{
		if (other != null)
		{
			oLHNBEPHHFG_.Add(other.oLHNBEPHHFG_);
			dOKHDOGAPKD_.Add(other.dOKHDOGAPKD_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
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
			case 82u:
				oLHNBEPHHFG_.AddEntriesFrom(ref input, _repeated_oLHNBEPHHFG_codec);
				break;
			case 90u:
				dOKHDOGAPKD_.AddEntriesFrom(ref input, _repeated_dOKHDOGAPKD_codec);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}

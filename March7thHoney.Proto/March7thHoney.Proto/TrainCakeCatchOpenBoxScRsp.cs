using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainCakeCatchOpenBoxScRsp : IMessage<TrainCakeCatchOpenBoxScRsp>, IMessage, IEquatable<TrainCakeCatchOpenBoxScRsp>, IDeepCloneable<TrainCakeCatchOpenBoxScRsp>, IBufferMessage
{
	private static readonly MessageParser<TrainCakeCatchOpenBoxScRsp> _parser = new MessageParser<TrainCakeCatchOpenBoxScRsp>(() => new TrainCakeCatchOpenBoxScRsp());

	private UnknownFieldSet _unknownFields;

	public const int AFEJACMLOLHFieldNumber = 6;

	private static readonly FieldCodec<NPLEDHFMFDM> _repeated_aFEJACMLOLH_codec = FieldCodec.ForMessage(50u, NPLEDHFMFDM.Parser);

	private readonly RepeatedField<NPLEDHFMFDM> aFEJACMLOLH_ = new RepeatedField<NPLEDHFMFDM>();

	public const int DHLGCEGONIBFieldNumber = 12;

	private long dHLGCEGONIB_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainCakeCatchOpenBoxScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainCakeCatchOpenBoxScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NPLEDHFMFDM> AFEJACMLOLH => aFEJACMLOLH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DHLGCEGONIB
	{
		get
		{
			return dHLGCEGONIB_;
		}
		set
		{
			dHLGCEGONIB_ = value;
		}
	}

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
	public TrainCakeCatchOpenBoxScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchOpenBoxScRsp(TrainCakeCatchOpenBoxScRsp other)
		: this()
	{
		aFEJACMLOLH_ = other.aFEJACMLOLH_.Clone();
		dHLGCEGONIB_ = other.dHLGCEGONIB_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchOpenBoxScRsp Clone()
	{
		return new TrainCakeCatchOpenBoxScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainCakeCatchOpenBoxScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainCakeCatchOpenBoxScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aFEJACMLOLH_.Equals(other.aFEJACMLOLH_))
		{
			return false;
		}
		if (DHLGCEGONIB != other.DHLGCEGONIB)
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
		num ^= aFEJACMLOLH_.GetHashCode();
		if (DHLGCEGONIB != 0L)
		{
			num ^= DHLGCEGONIB.GetHashCode();
		}
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
		aFEJACMLOLH_.WriteTo(ref output, _repeated_aFEJACMLOLH_codec);
		if (DHLGCEGONIB != 0L)
		{
			output.WriteRawTag(96);
			output.WriteInt64(DHLGCEGONIB);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
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
		num += aFEJACMLOLH_.CalculateSize(_repeated_aFEJACMLOLH_codec);
		if (DHLGCEGONIB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DHLGCEGONIB);
		}
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
	public void MergeFrom(TrainCakeCatchOpenBoxScRsp other)
	{
		if (other != null)
		{
			aFEJACMLOLH_.Add(other.aFEJACMLOLH_);
			if (other.DHLGCEGONIB != 0L)
			{
				DHLGCEGONIB = other.DHLGCEGONIB;
			}
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
			case 50u:
				aFEJACMLOLH_.AddEntriesFrom(ref input, _repeated_aFEJACMLOLH_codec);
				break;
			case 96u:
				DHLGCEGONIB = input.ReadInt64();
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}

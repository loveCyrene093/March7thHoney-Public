using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetChenLingGameBoyDataScRsp : IMessage<GetChenLingGameBoyDataScRsp>, IMessage, IEquatable<GetChenLingGameBoyDataScRsp>, IDeepCloneable<GetChenLingGameBoyDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetChenLingGameBoyDataScRsp> _parser = new MessageParser<GetChenLingGameBoyDataScRsp>(() => new GetChenLingGameBoyDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MAONHDCCHPEFieldNumber = 7;

	private EMHALJPDDBL mAONHDCCHPE_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetChenLingGameBoyDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetChenLingGameBoyDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMHALJPDDBL MAONHDCCHPE
	{
		get
		{
			return mAONHDCCHPE_;
		}
		set
		{
			mAONHDCCHPE_ = value;
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
	public GetChenLingGameBoyDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChenLingGameBoyDataScRsp(GetChenLingGameBoyDataScRsp other)
		: this()
	{
		mAONHDCCHPE_ = ((other.mAONHDCCHPE_ != null) ? other.mAONHDCCHPE_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChenLingGameBoyDataScRsp Clone()
	{
		return new GetChenLingGameBoyDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetChenLingGameBoyDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetChenLingGameBoyDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MAONHDCCHPE, other.MAONHDCCHPE))
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
		if (mAONHDCCHPE_ != null)
		{
			num ^= MAONHDCCHPE.GetHashCode();
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
		if (mAONHDCCHPE_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(MAONHDCCHPE);
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
		if (mAONHDCCHPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MAONHDCCHPE);
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
	public void MergeFrom(GetChenLingGameBoyDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mAONHDCCHPE_ != null)
		{
			if (mAONHDCCHPE_ == null)
			{
				MAONHDCCHPE = new EMHALJPDDBL();
			}
			MAONHDCCHPE.MergeFrom(other.MAONHDCCHPE);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 58u:
				if (mAONHDCCHPE_ == null)
				{
					MAONHDCCHPE = new EMHALJPDDBL();
				}
				input.ReadMessage(MAONHDCCHPE);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}

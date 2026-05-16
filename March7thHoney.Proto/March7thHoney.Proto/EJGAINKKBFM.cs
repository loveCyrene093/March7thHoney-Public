using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EJGAINKKBFM : IMessage<EJGAINKKBFM>, IMessage, IEquatable<EJGAINKKBFM>, IDeepCloneable<EJGAINKKBFM>, IBufferMessage
{
	private static readonly MessageParser<EJGAINKKBFM> _parser = new MessageParser<EJGAINKKBFM>(() => new EJGAINKKBFM());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int MAONHDCCHPEFieldNumber = 9;

	private NJBHKLCKHBK mAONHDCCHPE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EJGAINKKBFM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EJGAINKKBFMReflection.Descriptor.MessageTypes[0];

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
	public NJBHKLCKHBK MAONHDCCHPE
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
	public EJGAINKKBFM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EJGAINKKBFM(EJGAINKKBFM other)
		: this()
	{
		retcode_ = other.retcode_;
		mAONHDCCHPE_ = ((other.mAONHDCCHPE_ != null) ? other.mAONHDCCHPE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EJGAINKKBFM Clone()
	{
		return new EJGAINKKBFM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EJGAINKKBFM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EJGAINKKBFM other)
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
		if (!object.Equals(MAONHDCCHPE, other.MAONHDCCHPE))
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
		if (mAONHDCCHPE_ != null)
		{
			num ^= MAONHDCCHPE.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (mAONHDCCHPE_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(MAONHDCCHPE);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (mAONHDCCHPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MAONHDCCHPE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EJGAINKKBFM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.mAONHDCCHPE_ != null)
		{
			if (mAONHDCCHPE_ == null)
			{
				MAONHDCCHPE = new NJBHKLCKHBK();
			}
			MAONHDCCHPE.MergeFrom(other.MAONHDCCHPE);
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
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				if (mAONHDCCHPE_ == null)
				{
					MAONHDCCHPE = new NJBHKLCKHBK();
				}
				input.ReadMessage(MAONHDCCHPE);
				break;
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SelectPhoneCaseScRsp : IMessage<SelectPhoneCaseScRsp>, IMessage, IEquatable<SelectPhoneCaseScRsp>, IDeepCloneable<SelectPhoneCaseScRsp>, IBufferMessage
{
	private static readonly MessageParser<SelectPhoneCaseScRsp> _parser = new MessageParser<SelectPhoneCaseScRsp>(() => new SelectPhoneCaseScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int GMHOEABHKIGFieldNumber = 4;

	private uint gMHOEABHKIG_;

	public const int CurPhoneCaseFieldNumber = 10;

	private uint curPhoneCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SelectPhoneCaseScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SelectPhoneCaseScRspReflection.Descriptor.MessageTypes[0];

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
	public uint GMHOEABHKIG
	{
		get
		{
			return gMHOEABHKIG_;
		}
		set
		{
			gMHOEABHKIG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurPhoneCase
	{
		get
		{
			return curPhoneCase_;
		}
		set
		{
			curPhoneCase_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPhoneCaseScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPhoneCaseScRsp(SelectPhoneCaseScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		gMHOEABHKIG_ = other.gMHOEABHKIG_;
		curPhoneCase_ = other.curPhoneCase_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPhoneCaseScRsp Clone()
	{
		return new SelectPhoneCaseScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SelectPhoneCaseScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SelectPhoneCaseScRsp other)
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
		if (GMHOEABHKIG != other.GMHOEABHKIG)
		{
			return false;
		}
		if (CurPhoneCase != other.CurPhoneCase)
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
		if (GMHOEABHKIG != 0)
		{
			num ^= GMHOEABHKIG.GetHashCode();
		}
		if (CurPhoneCase != 0)
		{
			num ^= CurPhoneCase.GetHashCode();
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
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (GMHOEABHKIG != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GMHOEABHKIG);
		}
		if (CurPhoneCase != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CurPhoneCase);
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
		if (GMHOEABHKIG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GMHOEABHKIG);
		}
		if (CurPhoneCase != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurPhoneCase);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SelectPhoneCaseScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.GMHOEABHKIG != 0)
			{
				GMHOEABHKIG = other.GMHOEABHKIG;
			}
			if (other.CurPhoneCase != 0)
			{
				CurPhoneCase = other.CurPhoneCase;
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
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 32u:
				GMHOEABHKIG = input.ReadUInt32();
				break;
			case 80u:
				CurPhoneCase = input.ReadUInt32();
				break;
			}
		}
	}
}

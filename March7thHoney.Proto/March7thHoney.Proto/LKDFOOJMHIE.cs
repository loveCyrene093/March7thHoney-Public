using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LKDFOOJMHIE : IMessage<LKDFOOJMHIE>, IMessage, IEquatable<LKDFOOJMHIE>, IDeepCloneable<LKDFOOJMHIE>, IBufferMessage
{
	private static readonly MessageParser<LKDFOOJMHIE> _parser = new MessageParser<LKDFOOJMHIE>(() => new LKDFOOJMHIE());

	private UnknownFieldSet _unknownFields;

	public const int PENLMEIJIFKFieldNumber = 9;

	private uint pENLMEIJIFK_;

	public const int EFOFLGIDKKKFieldNumber = 12;

	private FDOEMKPGHFL eFOFLGIDKKK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LKDFOOJMHIE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LKDFOOJMHIEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PENLMEIJIFK
	{
		get
		{
			return pENLMEIJIFK_;
		}
		set
		{
			pENLMEIJIFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FDOEMKPGHFL EFOFLGIDKKK
	{
		get
		{
			return eFOFLGIDKKK_;
		}
		set
		{
			eFOFLGIDKKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKDFOOJMHIE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKDFOOJMHIE(LKDFOOJMHIE other)
		: this()
	{
		pENLMEIJIFK_ = other.pENLMEIJIFK_;
		eFOFLGIDKKK_ = ((other.eFOFLGIDKKK_ != null) ? other.eFOFLGIDKKK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKDFOOJMHIE Clone()
	{
		return new LKDFOOJMHIE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LKDFOOJMHIE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LKDFOOJMHIE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PENLMEIJIFK != other.PENLMEIJIFK)
		{
			return false;
		}
		if (!object.Equals(EFOFLGIDKKK, other.EFOFLGIDKKK))
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
		if (PENLMEIJIFK != 0)
		{
			num ^= PENLMEIJIFK.GetHashCode();
		}
		if (eFOFLGIDKKK_ != null)
		{
			num ^= EFOFLGIDKKK.GetHashCode();
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
		if (PENLMEIJIFK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PENLMEIJIFK);
		}
		if (eFOFLGIDKKK_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(EFOFLGIDKKK);
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
		if (PENLMEIJIFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PENLMEIJIFK);
		}
		if (eFOFLGIDKKK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EFOFLGIDKKK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LKDFOOJMHIE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PENLMEIJIFK != 0)
		{
			PENLMEIJIFK = other.PENLMEIJIFK;
		}
		if (other.eFOFLGIDKKK_ != null)
		{
			if (eFOFLGIDKKK_ == null)
			{
				EFOFLGIDKKK = new FDOEMKPGHFL();
			}
			EFOFLGIDKKK.MergeFrom(other.EFOFLGIDKKK);
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
			case 72u:
				PENLMEIJIFK = input.ReadUInt32();
				break;
			case 98u:
				if (eFOFLGIDKKK_ == null)
				{
					EFOFLGIDKKK = new FDOEMKPGHFL();
				}
				input.ReadMessage(EFOFLGIDKKK);
				break;
			}
		}
	}
}

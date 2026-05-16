using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IEMDAMOLKFL : IMessage<IEMDAMOLKFL>, IMessage, IEquatable<IEMDAMOLKFL>, IDeepCloneable<IEMDAMOLKFL>, IBufferMessage
{
	private static readonly MessageParser<IEMDAMOLKFL> _parser = new MessageParser<IEMDAMOLKFL>(() => new IEMDAMOLKFL());

	private UnknownFieldSet _unknownFields;

	public const int EKIMLIAMFHEFieldNumber = 2;

	private uint eKIMLIAMFHE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IEMDAMOLKFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IEMDAMOLKFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EKIMLIAMFHE
	{
		get
		{
			return eKIMLIAMFHE_;
		}
		set
		{
			eKIMLIAMFHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEMDAMOLKFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEMDAMOLKFL(IEMDAMOLKFL other)
		: this()
	{
		eKIMLIAMFHE_ = other.eKIMLIAMFHE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEMDAMOLKFL Clone()
	{
		return new IEMDAMOLKFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IEMDAMOLKFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IEMDAMOLKFL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EKIMLIAMFHE != other.EKIMLIAMFHE)
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
		if (EKIMLIAMFHE != 0)
		{
			num ^= EKIMLIAMFHE.GetHashCode();
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
		if (EKIMLIAMFHE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EKIMLIAMFHE);
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
		if (EKIMLIAMFHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EKIMLIAMFHE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IEMDAMOLKFL other)
	{
		if (other != null)
		{
			if (other.EKIMLIAMFHE != 0)
			{
				EKIMLIAMFHE = other.EKIMLIAMFHE;
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
			if (num != 16)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				EKIMLIAMFHE = input.ReadUInt32();
			}
		}
	}
}

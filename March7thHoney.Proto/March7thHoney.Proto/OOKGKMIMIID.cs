using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OOKGKMIMIID : IMessage<OOKGKMIMIID>, IMessage, IEquatable<OOKGKMIMIID>, IDeepCloneable<OOKGKMIMIID>, IBufferMessage
{
	private static readonly MessageParser<OOKGKMIMIID> _parser = new MessageParser<OOKGKMIMIID>(() => new OOKGKMIMIID());

	private UnknownFieldSet _unknownFields;

	public const int KBFDOPNODBLFieldNumber = 1;

	private uint kBFDOPNODBL_;

	public const int KKFBLJNMDFJFieldNumber = 6;

	private uint kKFBLJNMDFJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OOKGKMIMIID> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OOKGKMIMIIDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBFDOPNODBL
	{
		get
		{
			return kBFDOPNODBL_;
		}
		set
		{
			kBFDOPNODBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKFBLJNMDFJ
	{
		get
		{
			return kKFBLJNMDFJ_;
		}
		set
		{
			kKFBLJNMDFJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOKGKMIMIID()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOKGKMIMIID(OOKGKMIMIID other)
		: this()
	{
		kBFDOPNODBL_ = other.kBFDOPNODBL_;
		kKFBLJNMDFJ_ = other.kKFBLJNMDFJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOKGKMIMIID Clone()
	{
		return new OOKGKMIMIID(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OOKGKMIMIID);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OOKGKMIMIID other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KBFDOPNODBL != other.KBFDOPNODBL)
		{
			return false;
		}
		if (KKFBLJNMDFJ != other.KKFBLJNMDFJ)
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
		if (KBFDOPNODBL != 0)
		{
			num ^= KBFDOPNODBL.GetHashCode();
		}
		if (KKFBLJNMDFJ != 0)
		{
			num ^= KKFBLJNMDFJ.GetHashCode();
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
		if (KBFDOPNODBL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KBFDOPNODBL);
		}
		if (KKFBLJNMDFJ != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KKFBLJNMDFJ);
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
		if (KBFDOPNODBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBFDOPNODBL);
		}
		if (KKFBLJNMDFJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKFBLJNMDFJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OOKGKMIMIID other)
	{
		if (other != null)
		{
			if (other.KBFDOPNODBL != 0)
			{
				KBFDOPNODBL = other.KBFDOPNODBL;
			}
			if (other.KKFBLJNMDFJ != 0)
			{
				KKFBLJNMDFJ = other.KKFBLJNMDFJ;
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
			case 8u:
				KBFDOPNODBL = input.ReadUInt32();
				break;
			case 48u:
				KKFBLJNMDFJ = input.ReadUInt32();
				break;
			}
		}
	}
}

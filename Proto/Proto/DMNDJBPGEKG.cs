using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DMNDJBPGEKG : IMessage<DMNDJBPGEKG>, IMessage, IEquatable<DMNDJBPGEKG>, IDeepCloneable<DMNDJBPGEKG>, IBufferMessage
{
	private static readonly MessageParser<DMNDJBPGEKG> _parser = new MessageParser<DMNDJBPGEKG>(() => new DMNDJBPGEKG());

	private UnknownFieldSet _unknownFields;

	public const int HEIHGFAOFNKFieldNumber = 5;

	private uint hEIHGFAOFNK_;

	public const int KDOINLGKMBIFieldNumber = 7;

	private uint kDOINLGKMBI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DMNDJBPGEKG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DMNDJBPGEKGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEIHGFAOFNK
	{
		get
		{
			return hEIHGFAOFNK_;
		}
		set
		{
			hEIHGFAOFNK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KDOINLGKMBI
	{
		get
		{
			return kDOINLGKMBI_;
		}
		set
		{
			kDOINLGKMBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMNDJBPGEKG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMNDJBPGEKG(DMNDJBPGEKG other)
		: this()
	{
		hEIHGFAOFNK_ = other.hEIHGFAOFNK_;
		kDOINLGKMBI_ = other.kDOINLGKMBI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMNDJBPGEKG Clone()
	{
		return new DMNDJBPGEKG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DMNDJBPGEKG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DMNDJBPGEKG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HEIHGFAOFNK != other.HEIHGFAOFNK)
		{
			return false;
		}
		if (KDOINLGKMBI != other.KDOINLGKMBI)
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
		if (HEIHGFAOFNK != 0)
		{
			num ^= HEIHGFAOFNK.GetHashCode();
		}
		if (KDOINLGKMBI != 0)
		{
			num ^= KDOINLGKMBI.GetHashCode();
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
		if (HEIHGFAOFNK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HEIHGFAOFNK);
		}
		if (KDOINLGKMBI != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(KDOINLGKMBI);
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
		if (HEIHGFAOFNK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEIHGFAOFNK);
		}
		if (KDOINLGKMBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KDOINLGKMBI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DMNDJBPGEKG other)
	{
		if (other != null)
		{
			if (other.HEIHGFAOFNK != 0)
			{
				HEIHGFAOFNK = other.HEIHGFAOFNK;
			}
			if (other.KDOINLGKMBI != 0)
			{
				KDOINLGKMBI = other.KDOINLGKMBI;
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
			case 40u:
				HEIHGFAOFNK = input.ReadUInt32();
				break;
			case 56u:
				KDOINLGKMBI = input.ReadUInt32();
				break;
			}
		}
	}
}

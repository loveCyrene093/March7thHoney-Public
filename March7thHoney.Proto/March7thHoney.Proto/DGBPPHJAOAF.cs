using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DGBPPHJAOAF : IMessage<DGBPPHJAOAF>, IMessage, IEquatable<DGBPPHJAOAF>, IDeepCloneable<DGBPPHJAOAF>, IBufferMessage
{
	private static readonly MessageParser<DGBPPHJAOAF> _parser = new MessageParser<DGBPPHJAOAF>(() => new DGBPPHJAOAF());

	private UnknownFieldSet _unknownFields;

	public const int LPGAKJJFLJNFieldNumber = 7;

	private uint lPGAKJJFLJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DGBPPHJAOAF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DGBPPHJAOAFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LPGAKJJFLJN
	{
		get
		{
			return lPGAKJJFLJN_;
		}
		set
		{
			lPGAKJJFLJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGBPPHJAOAF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGBPPHJAOAF(DGBPPHJAOAF other)
		: this()
	{
		lPGAKJJFLJN_ = other.lPGAKJJFLJN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGBPPHJAOAF Clone()
	{
		return new DGBPPHJAOAF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DGBPPHJAOAF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DGBPPHJAOAF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LPGAKJJFLJN != other.LPGAKJJFLJN)
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
		if (LPGAKJJFLJN != 0)
		{
			num ^= LPGAKJJFLJN.GetHashCode();
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
		if (LPGAKJJFLJN != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(LPGAKJJFLJN);
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
		if (LPGAKJJFLJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LPGAKJJFLJN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DGBPPHJAOAF other)
	{
		if (other != null)
		{
			if (other.LPGAKJJFLJN != 0)
			{
				LPGAKJJFLJN = other.LPGAKJJFLJN;
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
			if (num != 56)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				LPGAKJJFLJN = input.ReadUInt32();
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class COEOHEBFICO : IMessage<COEOHEBFICO>, IMessage, IEquatable<COEOHEBFICO>, IDeepCloneable<COEOHEBFICO>, IBufferMessage
{
	private static readonly MessageParser<COEOHEBFICO> _parser = new MessageParser<COEOHEBFICO>(() => new COEOHEBFICO());

	private UnknownFieldSet _unknownFields;

	public const int BFBIIPMBFHFFieldNumber = 2;

	private uint bFBIIPMBFHF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<COEOHEBFICO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => COEOHEBFICOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BFBIIPMBFHF
	{
		get
		{
			return bFBIIPMBFHF_;
		}
		set
		{
			bFBIIPMBFHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COEOHEBFICO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COEOHEBFICO(COEOHEBFICO other)
		: this()
	{
		bFBIIPMBFHF_ = other.bFBIIPMBFHF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COEOHEBFICO Clone()
	{
		return new COEOHEBFICO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as COEOHEBFICO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(COEOHEBFICO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BFBIIPMBFHF != other.BFBIIPMBFHF)
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
		if (BFBIIPMBFHF != 0)
		{
			num ^= BFBIIPMBFHF.GetHashCode();
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
		if (BFBIIPMBFHF != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BFBIIPMBFHF);
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
		if (BFBIIPMBFHF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BFBIIPMBFHF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(COEOHEBFICO other)
	{
		if (other != null)
		{
			if (other.BFBIIPMBFHF != 0)
			{
				BFBIIPMBFHF = other.BFBIIPMBFHF;
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
				BFBIIPMBFHF = input.ReadUInt32();
			}
		}
	}
}

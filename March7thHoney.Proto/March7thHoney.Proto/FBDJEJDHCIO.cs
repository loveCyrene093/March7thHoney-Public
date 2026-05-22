using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FBDJEJDHCIO : IMessage<FBDJEJDHCIO>, IMessage, IEquatable<FBDJEJDHCIO>, IDeepCloneable<FBDJEJDHCIO>, IBufferMessage
{
	private static readonly MessageParser<FBDJEJDHCIO> _parser = new MessageParser<FBDJEJDHCIO>(() => new FBDJEJDHCIO());

	private UnknownFieldSet _unknownFields;

	public const int PPDMPMDMAOMFieldNumber = 1;

	private uint pPDMPMDMAOM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FBDJEJDHCIO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FBDJEJDHCIOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PPDMPMDMAOM
	{
		get
		{
			return pPDMPMDMAOM_;
		}
		set
		{
			pPDMPMDMAOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBDJEJDHCIO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBDJEJDHCIO(FBDJEJDHCIO other)
		: this()
	{
		pPDMPMDMAOM_ = other.pPDMPMDMAOM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBDJEJDHCIO Clone()
	{
		return new FBDJEJDHCIO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FBDJEJDHCIO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FBDJEJDHCIO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PPDMPMDMAOM != other.PPDMPMDMAOM)
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
		if (PPDMPMDMAOM != 0)
		{
			num ^= PPDMPMDMAOM.GetHashCode();
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
		if (PPDMPMDMAOM != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PPDMPMDMAOM);
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
		if (PPDMPMDMAOM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PPDMPMDMAOM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FBDJEJDHCIO other)
	{
		if (other != null)
		{
			if (other.PPDMPMDMAOM != 0)
			{
				PPDMPMDMAOM = other.PPDMPMDMAOM;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				PPDMPMDMAOM = input.ReadUInt32();
			}
		}
	}
}

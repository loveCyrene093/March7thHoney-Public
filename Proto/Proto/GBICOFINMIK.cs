using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GBICOFINMIK : IMessage<GBICOFINMIK>, IMessage, IEquatable<GBICOFINMIK>, IDeepCloneable<GBICOFINMIK>, IBufferMessage
{
	private static readonly MessageParser<GBICOFINMIK> _parser = new MessageParser<GBICOFINMIK>(() => new GBICOFINMIK());

	private UnknownFieldSet _unknownFields;

	public const int JBEILMFIIGMFieldNumber = 2;

	private uint jBEILMFIIGM_;

	public const int AHKFFCIEPDGFieldNumber = 4;

	private uint aHKFFCIEPDG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GBICOFINMIK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GBICOFINMIKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JBEILMFIIGM
	{
		get
		{
			return jBEILMFIIGM_;
		}
		set
		{
			jBEILMFIIGM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AHKFFCIEPDG
	{
		get
		{
			return aHKFFCIEPDG_;
		}
		set
		{
			aHKFFCIEPDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBICOFINMIK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBICOFINMIK(GBICOFINMIK other)
		: this()
	{
		jBEILMFIIGM_ = other.jBEILMFIIGM_;
		aHKFFCIEPDG_ = other.aHKFFCIEPDG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBICOFINMIK Clone()
	{
		return new GBICOFINMIK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GBICOFINMIK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GBICOFINMIK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JBEILMFIIGM != other.JBEILMFIIGM)
		{
			return false;
		}
		if (AHKFFCIEPDG != other.AHKFFCIEPDG)
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
		if (JBEILMFIIGM != 0)
		{
			num ^= JBEILMFIIGM.GetHashCode();
		}
		if (AHKFFCIEPDG != 0)
		{
			num ^= AHKFFCIEPDG.GetHashCode();
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
		if (JBEILMFIIGM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JBEILMFIIGM);
		}
		if (AHKFFCIEPDG != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AHKFFCIEPDG);
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
		if (JBEILMFIIGM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JBEILMFIIGM);
		}
		if (AHKFFCIEPDG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AHKFFCIEPDG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GBICOFINMIK other)
	{
		if (other != null)
		{
			if (other.JBEILMFIIGM != 0)
			{
				JBEILMFIIGM = other.JBEILMFIIGM;
			}
			if (other.AHKFFCIEPDG != 0)
			{
				AHKFFCIEPDG = other.AHKFFCIEPDG;
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
			case 16u:
				JBEILMFIIGM = input.ReadUInt32();
				break;
			case 32u:
				AHKFFCIEPDG = input.ReadUInt32();
				break;
			}
		}
	}
}

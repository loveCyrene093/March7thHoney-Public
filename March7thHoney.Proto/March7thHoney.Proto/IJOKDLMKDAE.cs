using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IJOKDLMKDAE : IMessage<IJOKDLMKDAE>, IMessage, IEquatable<IJOKDLMKDAE>, IDeepCloneable<IJOKDLMKDAE>, IBufferMessage
{
	private static readonly MessageParser<IJOKDLMKDAE> _parser = new MessageParser<IJOKDLMKDAE>(() => new IJOKDLMKDAE());

	private UnknownFieldSet _unknownFields;

	public const int ItemIdFieldNumber = 4;

	private uint itemId_;

	public const int HCNKAJNKGFHFieldNumber = 6;

	private uint hCNKAJNKGFH_;

	public const int HLKAFPCLMEOFieldNumber = 11;

	private bool hLKAFPCLMEO_;

	public const int KLNHLEJKDMLFieldNumber = 12;

	private bool kLNHLEJKDML_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IJOKDLMKDAE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IJOKDLMKDAEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCNKAJNKGFH
	{
		get
		{
			return hCNKAJNKGFH_;
		}
		set
		{
			hCNKAJNKGFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HLKAFPCLMEO
	{
		get
		{
			return hLKAFPCLMEO_;
		}
		set
		{
			hLKAFPCLMEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KLNHLEJKDML
	{
		get
		{
			return kLNHLEJKDML_;
		}
		set
		{
			kLNHLEJKDML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJOKDLMKDAE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJOKDLMKDAE(IJOKDLMKDAE other)
		: this()
	{
		itemId_ = other.itemId_;
		hCNKAJNKGFH_ = other.hCNKAJNKGFH_;
		hLKAFPCLMEO_ = other.hLKAFPCLMEO_;
		kLNHLEJKDML_ = other.kLNHLEJKDML_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJOKDLMKDAE Clone()
	{
		return new IJOKDLMKDAE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IJOKDLMKDAE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IJOKDLMKDAE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (HCNKAJNKGFH != other.HCNKAJNKGFH)
		{
			return false;
		}
		if (HLKAFPCLMEO != other.HLKAFPCLMEO)
		{
			return false;
		}
		if (KLNHLEJKDML != other.KLNHLEJKDML)
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
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (HCNKAJNKGFH != 0)
		{
			num ^= HCNKAJNKGFH.GetHashCode();
		}
		if (HLKAFPCLMEO)
		{
			num ^= HLKAFPCLMEO.GetHashCode();
		}
		if (KLNHLEJKDML)
		{
			num ^= KLNHLEJKDML.GetHashCode();
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
		if (ItemId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ItemId);
		}
		if (HCNKAJNKGFH != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(HCNKAJNKGFH);
		}
		if (HLKAFPCLMEO)
		{
			output.WriteRawTag(88);
			output.WriteBool(HLKAFPCLMEO);
		}
		if (KLNHLEJKDML)
		{
			output.WriteRawTag(96);
			output.WriteBool(KLNHLEJKDML);
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
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (HCNKAJNKGFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCNKAJNKGFH);
		}
		if (HLKAFPCLMEO)
		{
			num += 2;
		}
		if (KLNHLEJKDML)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IJOKDLMKDAE other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.HCNKAJNKGFH != 0)
			{
				HCNKAJNKGFH = other.HCNKAJNKGFH;
			}
			if (other.HLKAFPCLMEO)
			{
				HLKAFPCLMEO = other.HLKAFPCLMEO;
			}
			if (other.KLNHLEJKDML)
			{
				KLNHLEJKDML = other.KLNHLEJKDML;
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
			case 32u:
				ItemId = input.ReadUInt32();
				break;
			case 48u:
				HCNKAJNKGFH = input.ReadUInt32();
				break;
			case 88u:
				HLKAFPCLMEO = input.ReadBool();
				break;
			case 96u:
				KLNHLEJKDML = input.ReadBool();
				break;
			}
		}
	}
}

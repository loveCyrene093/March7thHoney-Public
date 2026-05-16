using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AMDMHJPPCNF : IMessage<AMDMHJPPCNF>, IMessage, IEquatable<AMDMHJPPCNF>, IDeepCloneable<AMDMHJPPCNF>, IBufferMessage
{
	private static readonly MessageParser<AMDMHJPPCNF> _parser = new MessageParser<AMDMHJPPCNF>(() => new AMDMHJPPCNF());

	private UnknownFieldSet _unknownFields;

	public const int EDDHKOAPLEIFieldNumber = 1;

	private string eDDHKOAPLEI_ = "";

	public const int CountFieldNumber = 2;

	private uint count_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AMDMHJPPCNF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AMDMHJPPCNFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string EDDHKOAPLEI
	{
		get
		{
			return eDDHKOAPLEI_;
		}
		set
		{
			eDDHKOAPLEI_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMDMHJPPCNF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMDMHJPPCNF(AMDMHJPPCNF other)
		: this()
	{
		eDDHKOAPLEI_ = other.eDDHKOAPLEI_;
		count_ = other.count_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AMDMHJPPCNF Clone()
	{
		return new AMDMHJPPCNF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AMDMHJPPCNF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AMDMHJPPCNF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EDDHKOAPLEI != other.EDDHKOAPLEI)
		{
			return false;
		}
		if (Count != other.Count)
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
		if (EDDHKOAPLEI.Length != 0)
		{
			num ^= EDDHKOAPLEI.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
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
		if (EDDHKOAPLEI.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(EDDHKOAPLEI);
		}
		if (Count != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Count);
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
		if (EDDHKOAPLEI.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EDDHKOAPLEI);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AMDMHJPPCNF other)
	{
		if (other != null)
		{
			if (other.EDDHKOAPLEI.Length != 0)
			{
				EDDHKOAPLEI = other.EDDHKOAPLEI;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
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
			case 10u:
				EDDHKOAPLEI = input.ReadString();
				break;
			case 16u:
				Count = input.ReadUInt32();
				break;
			}
		}
	}
}

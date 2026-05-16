using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PICILIIFKBE : IMessage<PICILIIFKBE>, IMessage, IEquatable<PICILIIFKBE>, IDeepCloneable<PICILIIFKBE>, IBufferMessage
{
	private static readonly MessageParser<PICILIIFKBE> _parser = new MessageParser<PICILIIFKBE>(() => new PICILIIFKBE());

	private UnknownFieldSet _unknownFields;

	public const int DMMFMNKHFHHFieldNumber = 3;

	private uint dMMFMNKHFHH_;

	public const int ScriptIdFieldNumber = 13;

	private uint scriptId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PICILIIFKBE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PICILIIFKBEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DMMFMNKHFHH
	{
		get
		{
			return dMMFMNKHFHH_;
		}
		set
		{
			dMMFMNKHFHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScriptId
	{
		get
		{
			return scriptId_;
		}
		set
		{
			scriptId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PICILIIFKBE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PICILIIFKBE(PICILIIFKBE other)
		: this()
	{
		dMMFMNKHFHH_ = other.dMMFMNKHFHH_;
		scriptId_ = other.scriptId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PICILIIFKBE Clone()
	{
		return new PICILIIFKBE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PICILIIFKBE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PICILIIFKBE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DMMFMNKHFHH != other.DMMFMNKHFHH)
		{
			return false;
		}
		if (ScriptId != other.ScriptId)
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
		if (DMMFMNKHFHH != 0)
		{
			num ^= DMMFMNKHFHH.GetHashCode();
		}
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
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
		if (DMMFMNKHFHH != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DMMFMNKHFHH);
		}
		if (ScriptId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ScriptId);
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
		if (DMMFMNKHFHH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DMMFMNKHFHH);
		}
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PICILIIFKBE other)
	{
		if (other != null)
		{
			if (other.DMMFMNKHFHH != 0)
			{
				DMMFMNKHFHH = other.DMMFMNKHFHH;
			}
			if (other.ScriptId != 0)
			{
				ScriptId = other.ScriptId;
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
			case 24u:
				DMMFMNKHFHH = input.ReadUInt32();
				break;
			case 104u:
				ScriptId = input.ReadUInt32();
				break;
			}
		}
	}
}

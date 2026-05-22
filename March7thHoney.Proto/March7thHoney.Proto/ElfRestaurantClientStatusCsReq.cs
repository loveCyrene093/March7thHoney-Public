using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ElfRestaurantClientStatusCsReq : IMessage<ElfRestaurantClientStatusCsReq>, IMessage, IEquatable<ElfRestaurantClientStatusCsReq>, IDeepCloneable<ElfRestaurantClientStatusCsReq>, IBufferMessage
{
	private static readonly MessageParser<ElfRestaurantClientStatusCsReq> _parser = new MessageParser<ElfRestaurantClientStatusCsReq>(() => new ElfRestaurantClientStatusCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HCBEDECLAICFieldNumber = 14;

	private bool hCBEDECLAIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ElfRestaurantClientStatusCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ElfRestaurantClientStatusCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HCBEDECLAIC
	{
		get
		{
			return hCBEDECLAIC_;
		}
		set
		{
			hCBEDECLAIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantClientStatusCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantClientStatusCsReq(ElfRestaurantClientStatusCsReq other)
		: this()
	{
		hCBEDECLAIC_ = other.hCBEDECLAIC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ElfRestaurantClientStatusCsReq Clone()
	{
		return new ElfRestaurantClientStatusCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ElfRestaurantClientStatusCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ElfRestaurantClientStatusCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HCBEDECLAIC != other.HCBEDECLAIC)
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
		if (HCBEDECLAIC)
		{
			num ^= HCBEDECLAIC.GetHashCode();
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
		if (HCBEDECLAIC)
		{
			output.WriteRawTag(112);
			output.WriteBool(HCBEDECLAIC);
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
		if (HCBEDECLAIC)
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
	public void MergeFrom(ElfRestaurantClientStatusCsReq other)
	{
		if (other != null)
		{
			if (other.HCBEDECLAIC)
			{
				HCBEDECLAIC = other.HCBEDECLAIC;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				HCBEDECLAIC = input.ReadBool();
			}
		}
	}
}

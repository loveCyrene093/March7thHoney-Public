using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DrinkMakerUpdateTipsNotify : IMessage<DrinkMakerUpdateTipsNotify>, IMessage, IEquatable<DrinkMakerUpdateTipsNotify>, IDeepCloneable<DrinkMakerUpdateTipsNotify>, IBufferMessage
{
	private static readonly MessageParser<DrinkMakerUpdateTipsNotify> _parser = new MessageParser<DrinkMakerUpdateTipsNotify>(() => new DrinkMakerUpdateTipsNotify());

	private UnknownFieldSet _unknownFields;

	public const int EDBOHDJDJAAFieldNumber = 11;

	private uint eDBOHDJDJAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DrinkMakerUpdateTipsNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DrinkMakerUpdateTipsNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDBOHDJDJAA
	{
		get
		{
			return eDBOHDJDJAA_;
		}
		set
		{
			eDBOHDJDJAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerUpdateTipsNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerUpdateTipsNotify(DrinkMakerUpdateTipsNotify other)
		: this()
	{
		eDBOHDJDJAA_ = other.eDBOHDJDJAA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerUpdateTipsNotify Clone()
	{
		return new DrinkMakerUpdateTipsNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DrinkMakerUpdateTipsNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DrinkMakerUpdateTipsNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EDBOHDJDJAA != other.EDBOHDJDJAA)
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
		if (EDBOHDJDJAA != 0)
		{
			num ^= EDBOHDJDJAA.GetHashCode();
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
		if (EDBOHDJDJAA != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(EDBOHDJDJAA);
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
		if (EDBOHDJDJAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDBOHDJDJAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DrinkMakerUpdateTipsNotify other)
	{
		if (other != null)
		{
			if (other.EDBOHDJDJAA != 0)
			{
				EDBOHDJDJAA = other.EDBOHDJDJAA;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				EDBOHDJDJAA = input.ReadUInt32();
			}
		}
	}
}

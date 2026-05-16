using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetDrinkMakerDayEndScNotify : IMessage<GetDrinkMakerDayEndScNotify>, IMessage, IEquatable<GetDrinkMakerDayEndScNotify>, IDeepCloneable<GetDrinkMakerDayEndScNotify>, IBufferMessage
{
	private static readonly MessageParser<GetDrinkMakerDayEndScNotify> _parser = new MessageParser<GetDrinkMakerDayEndScNotify>(() => new GetDrinkMakerDayEndScNotify());

	private UnknownFieldSet _unknownFields;

	public const int IGJKLCDCLIJFieldNumber = 9;

	private uint iGJKLCDCLIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetDrinkMakerDayEndScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetDrinkMakerDayEndScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGJKLCDCLIJ
	{
		get
		{
			return iGJKLCDCLIJ_;
		}
		set
		{
			iGJKLCDCLIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetDrinkMakerDayEndScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetDrinkMakerDayEndScNotify(GetDrinkMakerDayEndScNotify other)
		: this()
	{
		iGJKLCDCLIJ_ = other.iGJKLCDCLIJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetDrinkMakerDayEndScNotify Clone()
	{
		return new GetDrinkMakerDayEndScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetDrinkMakerDayEndScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetDrinkMakerDayEndScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IGJKLCDCLIJ != other.IGJKLCDCLIJ)
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
		if (IGJKLCDCLIJ != 0)
		{
			num ^= IGJKLCDCLIJ.GetHashCode();
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
		if (IGJKLCDCLIJ != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(IGJKLCDCLIJ);
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
		if (IGJKLCDCLIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGJKLCDCLIJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetDrinkMakerDayEndScNotify other)
	{
		if (other != null)
		{
			if (other.IGJKLCDCLIJ != 0)
			{
				IGJKLCDCLIJ = other.IGJKLCDCLIJ;
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
			if (num != 72)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				IGJKLCDCLIJ = input.ReadUInt32();
			}
		}
	}
}

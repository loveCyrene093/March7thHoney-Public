using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AetherDivideTainerInfoScNotify : IMessage<AetherDivideTainerInfoScNotify>, IMessage, IEquatable<AetherDivideTainerInfoScNotify>, IDeepCloneable<AetherDivideTainerInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<AetherDivideTainerInfoScNotify> _parser = new MessageParser<AetherDivideTainerInfoScNotify>(() => new AetherDivideTainerInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CFCFCEBNAEFFieldNumber = 12;

	private uint cFCFCEBNAEF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AetherDivideTainerInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AetherDivideTainerInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CFCFCEBNAEF
	{
		get
		{
			return cFCFCEBNAEF_;
		}
		set
		{
			cFCFCEBNAEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideTainerInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideTainerInfoScNotify(AetherDivideTainerInfoScNotify other)
		: this()
	{
		cFCFCEBNAEF_ = other.cFCFCEBNAEF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideTainerInfoScNotify Clone()
	{
		return new AetherDivideTainerInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AetherDivideTainerInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AetherDivideTainerInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CFCFCEBNAEF != other.CFCFCEBNAEF)
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
		if (CFCFCEBNAEF != 0)
		{
			num ^= CFCFCEBNAEF.GetHashCode();
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
		if (CFCFCEBNAEF != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CFCFCEBNAEF);
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
		if (CFCFCEBNAEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CFCFCEBNAEF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AetherDivideTainerInfoScNotify other)
	{
		if (other != null)
		{
			if (other.CFCFCEBNAEF != 0)
			{
				CFCFCEBNAEF = other.CFCFCEBNAEF;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CFCFCEBNAEF = input.ReadUInt32();
			}
		}
	}
}

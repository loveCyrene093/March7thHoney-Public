using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightTraitInfoPb : IMessage<GridFightTraitInfoPb>, IMessage, IEquatable<GridFightTraitInfoPb>, IDeepCloneable<GridFightTraitInfoPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightTraitInfoPb> _parser = new MessageParser<GridFightTraitInfoPb>(() => new GridFightTraitInfoPb());

	private UnknownFieldSet _unknownFields;

	public const int TraitsFieldNumber = 1;

	private static readonly FieldCodec<GridFightGameTraitPb> _repeated_traits_codec = FieldCodec.ForMessage(10u, GridFightGameTraitPb.Parser);

	private readonly RepeatedField<GridFightGameTraitPb> traits_ = new RepeatedField<GridFightGameTraitPb>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightTraitInfoPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[18];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightGameTraitPb> Traits => traits_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitInfoPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitInfoPb(GridFightTraitInfoPb other)
		: this()
	{
		traits_ = other.traits_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitInfoPb Clone()
	{
		return new GridFightTraitInfoPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightTraitInfoPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightTraitInfoPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!traits_.Equals(other.traits_))
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
		num ^= traits_.GetHashCode();
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
		traits_.WriteTo(ref output, _repeated_traits_codec);
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
		num += traits_.CalculateSize(_repeated_traits_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightTraitInfoPb other)
	{
		if (other != null)
		{
			traits_.Add(other.traits_);
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
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				traits_.AddEntriesFrom(ref input, _repeated_traits_codec);
			}
		}
	}
}

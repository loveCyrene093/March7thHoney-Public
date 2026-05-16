using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MazeCrossFloorConditionChangeScNotify : IMessage<MazeCrossFloorConditionChangeScNotify>, IMessage, IEquatable<MazeCrossFloorConditionChangeScNotify>, IDeepCloneable<MazeCrossFloorConditionChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<MazeCrossFloorConditionChangeScNotify> _parser = new MessageParser<MazeCrossFloorConditionChangeScNotify>(() => new MazeCrossFloorConditionChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int PHCAALBPKGKFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_pHCAALBPKGK_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> pHCAALBPKGK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MazeCrossFloorConditionChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MazeCrossFloorConditionChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PHCAALBPKGK => pHCAALBPKGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazeCrossFloorConditionChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazeCrossFloorConditionChangeScNotify(MazeCrossFloorConditionChangeScNotify other)
		: this()
	{
		pHCAALBPKGK_ = other.pHCAALBPKGK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MazeCrossFloorConditionChangeScNotify Clone()
	{
		return new MazeCrossFloorConditionChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MazeCrossFloorConditionChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MazeCrossFloorConditionChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pHCAALBPKGK_.Equals(other.pHCAALBPKGK_))
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
		num ^= pHCAALBPKGK_.GetHashCode();
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
		pHCAALBPKGK_.WriteTo(ref output, _repeated_pHCAALBPKGK_codec);
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
		num += pHCAALBPKGK_.CalculateSize(_repeated_pHCAALBPKGK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MazeCrossFloorConditionChangeScNotify other)
	{
		if (other != null)
		{
			pHCAALBPKGK_.Add(other.pHCAALBPKGK_);
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
			if (num != 80 && num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				pHCAALBPKGK_.AddEntriesFrom(ref input, _repeated_pHCAALBPKGK_codec);
			}
		}
	}
}

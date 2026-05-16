using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyBuildingUpdateNotify : IMessage<TrainPartyBuildingUpdateNotify>, IMessage, IEquatable<TrainPartyBuildingUpdateNotify>, IDeepCloneable<TrainPartyBuildingUpdateNotify>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyBuildingUpdateNotify> _parser = new MessageParser<TrainPartyBuildingUpdateNotify>(() => new TrainPartyBuildingUpdateNotify());

	private UnknownFieldSet _unknownFields;

	public const int DFALHBBMNFJFieldNumber = 2;

	private static readonly FieldCodec<EJHCJCLHLFL> _repeated_dFALHBBMNFJ_codec = FieldCodec.ForMessage(18u, EJHCJCLHLFL.Parser);

	private readonly RepeatedField<EJHCJCLHLFL> dFALHBBMNFJ_ = new RepeatedField<EJHCJCLHLFL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyBuildingUpdateNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyBuildingUpdateNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EJHCJCLHLFL> DFALHBBMNFJ => dFALHBBMNFJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildingUpdateNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildingUpdateNotify(TrainPartyBuildingUpdateNotify other)
		: this()
	{
		dFALHBBMNFJ_ = other.dFALHBBMNFJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildingUpdateNotify Clone()
	{
		return new TrainPartyBuildingUpdateNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyBuildingUpdateNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyBuildingUpdateNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dFALHBBMNFJ_.Equals(other.dFALHBBMNFJ_))
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
		num ^= dFALHBBMNFJ_.GetHashCode();
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
		dFALHBBMNFJ_.WriteTo(ref output, _repeated_dFALHBBMNFJ_codec);
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
		num += dFALHBBMNFJ_.CalculateSize(_repeated_dFALHBBMNFJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyBuildingUpdateNotify other)
	{
		if (other != null)
		{
			dFALHBBMNFJ_.Add(other.dFALHBBMNFJ_);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dFALHBBMNFJ_.AddEntriesFrom(ref input, _repeated_dFALHBBMNFJ_codec);
			}
		}
	}
}

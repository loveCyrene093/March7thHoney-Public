using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FateSyncActionResultScNotify : IMessage<FateSyncActionResultScNotify>, IMessage, IEquatable<FateSyncActionResultScNotify>, IDeepCloneable<FateSyncActionResultScNotify>, IBufferMessage
{
	private static readonly MessageParser<FateSyncActionResultScNotify> _parser = new MessageParser<FateSyncActionResultScNotify>(() => new FateSyncActionResultScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ANIADNFEMAHFieldNumber = 15;

	private static readonly FieldCodec<KNFLEFIFKMN> _repeated_aNIADNFEMAH_codec = FieldCodec.ForMessage(122u, KNFLEFIFKMN.Parser);

	private readonly RepeatedField<KNFLEFIFKMN> aNIADNFEMAH_ = new RepeatedField<KNFLEFIFKMN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FateSyncActionResultScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FateSyncActionResultScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KNFLEFIFKMN> ANIADNFEMAH => aNIADNFEMAH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateSyncActionResultScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateSyncActionResultScNotify(FateSyncActionResultScNotify other)
		: this()
	{
		aNIADNFEMAH_ = other.aNIADNFEMAH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateSyncActionResultScNotify Clone()
	{
		return new FateSyncActionResultScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FateSyncActionResultScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FateSyncActionResultScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aNIADNFEMAH_.Equals(other.aNIADNFEMAH_))
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
		num ^= aNIADNFEMAH_.GetHashCode();
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
		aNIADNFEMAH_.WriteTo(ref output, _repeated_aNIADNFEMAH_codec);
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
		num += aNIADNFEMAH_.CalculateSize(_repeated_aNIADNFEMAH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FateSyncActionResultScNotify other)
	{
		if (other != null)
		{
			aNIADNFEMAH_.Add(other.aNIADNFEMAH_);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				aNIADNFEMAH_.AddEntriesFrom(ref input, _repeated_aNIADNFEMAH_codec);
			}
		}
	}
}

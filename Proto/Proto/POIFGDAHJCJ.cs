using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class POIFGDAHJCJ : IMessage<POIFGDAHJCJ>, IMessage, IEquatable<POIFGDAHJCJ>, IDeepCloneable<POIFGDAHJCJ>, IBufferMessage
{
	private static readonly MessageParser<POIFGDAHJCJ> _parser = new MessageParser<POIFGDAHJCJ>(() => new POIFGDAHJCJ());

	private UnknownFieldSet _unknownFields;

	public const int BEGNBCCEPKEFieldNumber = 2;

	private static readonly MapField<uint, bool>.Codec _map_bEGNBCCEPKE_codec = new MapField<uint, bool>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForBool(16u, defaultValue: false), 18u);

	private readonly MapField<uint, bool> bEGNBCCEPKE_ = new MapField<uint, bool>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<POIFGDAHJCJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => POIFGDAHJCJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, bool> BEGNBCCEPKE => bEGNBCCEPKE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POIFGDAHJCJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POIFGDAHJCJ(POIFGDAHJCJ other)
		: this()
	{
		bEGNBCCEPKE_ = other.bEGNBCCEPKE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POIFGDAHJCJ Clone()
	{
		return new POIFGDAHJCJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as POIFGDAHJCJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(POIFGDAHJCJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!BEGNBCCEPKE.Equals(other.BEGNBCCEPKE))
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
		num ^= BEGNBCCEPKE.GetHashCode();
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
		bEGNBCCEPKE_.WriteTo(ref output, _map_bEGNBCCEPKE_codec);
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
		num += bEGNBCCEPKE_.CalculateSize(_map_bEGNBCCEPKE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(POIFGDAHJCJ other)
	{
		if (other != null)
		{
			bEGNBCCEPKE_.MergeFrom(other.bEGNBCCEPKE_);
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
				bEGNBCCEPKE_.AddEntriesFrom(ref input, _map_bEGNBCCEPKE_codec);
			}
		}
	}
}

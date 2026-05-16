using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CCBKGJGNDCL : IMessage<CCBKGJGNDCL>, IMessage, IEquatable<CCBKGJGNDCL>, IDeepCloneable<CCBKGJGNDCL>, IBufferMessage
{
	private static readonly MessageParser<CCBKGJGNDCL> _parser = new MessageParser<CCBKGJGNDCL>(() => new CCBKGJGNDCL());

	private UnknownFieldSet _unknownFields;

	public const int FGKAOMIJJBNFieldNumber = 3;

	private static readonly FieldCodec<NHPKMMDOHIH> _repeated_fGKAOMIJJBN_codec = FieldCodec.ForMessage(26u, NHPKMMDOHIH.Parser);

	private readonly RepeatedField<NHPKMMDOHIH> fGKAOMIJJBN_ = new RepeatedField<NHPKMMDOHIH>();

	public const int CostTimeFieldNumber = 8;

	private uint costTime_;

	public const int MapIdFieldNumber = 12;

	private uint mapId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CCBKGJGNDCL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CCBKGJGNDCLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NHPKMMDOHIH> FGKAOMIJJBN => fGKAOMIJJBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CostTime
	{
		get
		{
			return costTime_;
		}
		set
		{
			costTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCBKGJGNDCL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCBKGJGNDCL(CCBKGJGNDCL other)
		: this()
	{
		fGKAOMIJJBN_ = other.fGKAOMIJJBN_.Clone();
		costTime_ = other.costTime_;
		mapId_ = other.mapId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCBKGJGNDCL Clone()
	{
		return new CCBKGJGNDCL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CCBKGJGNDCL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CCBKGJGNDCL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fGKAOMIJJBN_.Equals(other.fGKAOMIJJBN_))
		{
			return false;
		}
		if (CostTime != other.CostTime)
		{
			return false;
		}
		if (MapId != other.MapId)
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
		num ^= fGKAOMIJJBN_.GetHashCode();
		if (CostTime != 0)
		{
			num ^= CostTime.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
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
		fGKAOMIJJBN_.WriteTo(ref output, _repeated_fGKAOMIJJBN_codec);
		if (CostTime != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(CostTime);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(MapId);
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
		num += fGKAOMIJJBN_.CalculateSize(_repeated_fGKAOMIJJBN_codec);
		if (CostTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CostTime);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CCBKGJGNDCL other)
	{
		if (other != null)
		{
			fGKAOMIJJBN_.Add(other.fGKAOMIJJBN_);
			if (other.CostTime != 0)
			{
				CostTime = other.CostTime;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
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
			case 26u:
				fGKAOMIJJBN_.AddEntriesFrom(ref input, _repeated_fGKAOMIJJBN_codec);
				break;
			case 64u:
				CostTime = input.ReadUInt32();
				break;
			case 96u:
				MapId = input.ReadUInt32();
				break;
			}
		}
	}
}

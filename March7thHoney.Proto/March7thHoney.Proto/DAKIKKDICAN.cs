using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DAKIKKDICAN : IMessage<DAKIKKDICAN>, IMessage, IEquatable<DAKIKKDICAN>, IDeepCloneable<DAKIKKDICAN>, IBufferMessage
{
	private static readonly MessageParser<DAKIKKDICAN> _parser = new MessageParser<DAKIKKDICAN>(() => new DAKIKKDICAN());

	private UnknownFieldSet _unknownFields;

	public const int AGGLBDEHHGOFieldNumber = 12;

	private uint aGGLBDEHHGO_;

	public const int MonsterIdFieldNumber = 14;

	private uint monsterId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DAKIKKDICAN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DAKIKKDICANReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AGGLBDEHHGO
	{
		get
		{
			return aGGLBDEHHGO_;
		}
		set
		{
			aGGLBDEHHGO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAKIKKDICAN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAKIKKDICAN(DAKIKKDICAN other)
		: this()
	{
		aGGLBDEHHGO_ = other.aGGLBDEHHGO_;
		monsterId_ = other.monsterId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAKIKKDICAN Clone()
	{
		return new DAKIKKDICAN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DAKIKKDICAN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DAKIKKDICAN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AGGLBDEHHGO != other.AGGLBDEHHGO)
		{
			return false;
		}
		if (MonsterId != other.MonsterId)
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
		if (AGGLBDEHHGO != 0)
		{
			num ^= AGGLBDEHHGO.GetHashCode();
		}
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
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
		if (AGGLBDEHHGO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(AGGLBDEHHGO);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MonsterId);
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
		if (AGGLBDEHHGO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AGGLBDEHHGO);
		}
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DAKIKKDICAN other)
	{
		if (other != null)
		{
			if (other.AGGLBDEHHGO != 0)
			{
				AGGLBDEHHGO = other.AGGLBDEHHGO;
			}
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
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
			case 96u:
				AGGLBDEHHGO = input.ReadUInt32();
				break;
			case 112u:
				MonsterId = input.ReadUInt32();
				break;
			}
		}
	}
}

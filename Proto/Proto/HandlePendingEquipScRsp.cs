using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HandlePendingEquipScRsp : IMessage<HandlePendingEquipScRsp>, IMessage, IEquatable<HandlePendingEquipScRsp>, IDeepCloneable<HandlePendingEquipScRsp>, IBufferMessage
{
	private static readonly MessageParser<HandlePendingEquipScRsp> _parser = new MessageParser<HandlePendingEquipScRsp>(() => new HandlePendingEquipScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int DGKEEOEIOBBFieldNumber = 3;

	private IJPFIHHGNGP dGKEEOEIOBB_;

	public const int DiscardedFieldNumber = 13;

	private bool discarded_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HandlePendingEquipScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HandlePendingEquipScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJPFIHHGNGP DGKEEOEIOBB
	{
		get
		{
			return dGKEEOEIOBB_;
		}
		set
		{
			dGKEEOEIOBB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Discarded
	{
		get
		{
			return discarded_;
		}
		set
		{
			discarded_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HandlePendingEquipScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HandlePendingEquipScRsp(HandlePendingEquipScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		dGKEEOEIOBB_ = ((other.dGKEEOEIOBB_ != null) ? other.dGKEEOEIOBB_.Clone() : null);
		discarded_ = other.discarded_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HandlePendingEquipScRsp Clone()
	{
		return new HandlePendingEquipScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HandlePendingEquipScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HandlePendingEquipScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(DGKEEOEIOBB, other.DGKEEOEIOBB))
		{
			return false;
		}
		if (Discarded != other.Discarded)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (dGKEEOEIOBB_ != null)
		{
			num ^= DGKEEOEIOBB.GetHashCode();
		}
		if (Discarded)
		{
			num ^= Discarded.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (dGKEEOEIOBB_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(DGKEEOEIOBB);
		}
		if (Discarded)
		{
			output.WriteRawTag(104);
			output.WriteBool(Discarded);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (dGKEEOEIOBB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DGKEEOEIOBB);
		}
		if (Discarded)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HandlePendingEquipScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.dGKEEOEIOBB_ != null)
		{
			if (dGKEEOEIOBB_ == null)
			{
				DGKEEOEIOBB = new IJPFIHHGNGP();
			}
			DGKEEOEIOBB.MergeFrom(other.DGKEEOEIOBB);
		}
		if (other.Discarded)
		{
			Discarded = other.Discarded;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 26u:
				if (dGKEEOEIOBB_ == null)
				{
					DGKEEOEIOBB = new IJPFIHHGNGP();
				}
				input.ReadMessage(DGKEEOEIOBB);
				break;
			case 104u:
				Discarded = input.ReadBool();
				break;
			}
		}
	}
}

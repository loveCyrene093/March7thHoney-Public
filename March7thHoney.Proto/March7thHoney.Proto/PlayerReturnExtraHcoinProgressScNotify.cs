using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerReturnExtraHcoinProgressScNotify : IMessage<PlayerReturnExtraHcoinProgressScNotify>, IMessage, IEquatable<PlayerReturnExtraHcoinProgressScNotify>, IDeepCloneable<PlayerReturnExtraHcoinProgressScNotify>, IBufferMessage
{
	private static readonly MessageParser<PlayerReturnExtraHcoinProgressScNotify> _parser = new MessageParser<PlayerReturnExtraHcoinProgressScNotify>(() => new PlayerReturnExtraHcoinProgressScNotify());

	private UnknownFieldSet _unknownFields;

	public const int PPCAPBMKGACFieldNumber = 5;

	private uint pPCAPBMKGAC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerReturnExtraHcoinProgressScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerReturnExtraHcoinProgressScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PPCAPBMKGAC
	{
		get
		{
			return pPCAPBMKGAC_;
		}
		set
		{
			pPCAPBMKGAC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnExtraHcoinProgressScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnExtraHcoinProgressScNotify(PlayerReturnExtraHcoinProgressScNotify other)
		: this()
	{
		pPCAPBMKGAC_ = other.pPCAPBMKGAC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnExtraHcoinProgressScNotify Clone()
	{
		return new PlayerReturnExtraHcoinProgressScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerReturnExtraHcoinProgressScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerReturnExtraHcoinProgressScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PPCAPBMKGAC != other.PPCAPBMKGAC)
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
		if (PPCAPBMKGAC != 0)
		{
			num ^= PPCAPBMKGAC.GetHashCode();
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
		if (PPCAPBMKGAC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PPCAPBMKGAC);
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
		if (PPCAPBMKGAC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PPCAPBMKGAC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerReturnExtraHcoinProgressScNotify other)
	{
		if (other != null)
		{
			if (other.PPCAPBMKGAC != 0)
			{
				PPCAPBMKGAC = other.PPCAPBMKGAC;
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
			if (num != 40)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				PPCAPBMKGAC = input.ReadUInt32();
			}
		}
	}
}

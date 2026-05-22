using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveOpenChestReq : IMessage<IdleLiveOpenChestReq>, IMessage, IEquatable<IdleLiveOpenChestReq>, IDeepCloneable<IdleLiveOpenChestReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveOpenChestReq> _parser = new MessageParser<IdleLiveOpenChestReq>(() => new IdleLiveOpenChestReq());

	private UnknownFieldSet _unknownFields;

	public const int IPCOEGGAJLKFieldNumber = 1;

	private uint iPCOEGGAJLK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveOpenChestReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveOpenChestReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPCOEGGAJLK
	{
		get
		{
			return iPCOEGGAJLK_;
		}
		set
		{
			iPCOEGGAJLK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveOpenChestReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveOpenChestReq(IdleLiveOpenChestReq other)
		: this()
	{
		iPCOEGGAJLK_ = other.iPCOEGGAJLK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveOpenChestReq Clone()
	{
		return new IdleLiveOpenChestReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveOpenChestReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveOpenChestReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IPCOEGGAJLK != other.IPCOEGGAJLK)
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
		if (IPCOEGGAJLK != 0)
		{
			num ^= IPCOEGGAJLK.GetHashCode();
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
		if (IPCOEGGAJLK != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IPCOEGGAJLK);
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
		if (IPCOEGGAJLK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPCOEGGAJLK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveOpenChestReq other)
	{
		if (other != null)
		{
			if (other.IPCOEGGAJLK != 0)
			{
				IPCOEGGAJLK = other.IPCOEGGAJLK;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				IPCOEGGAJLK = input.ReadUInt32();
			}
		}
	}
}

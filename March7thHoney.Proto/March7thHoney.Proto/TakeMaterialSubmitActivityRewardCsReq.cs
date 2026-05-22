using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeMaterialSubmitActivityRewardCsReq : IMessage<TakeMaterialSubmitActivityRewardCsReq>, IMessage, IEquatable<TakeMaterialSubmitActivityRewardCsReq>, IDeepCloneable<TakeMaterialSubmitActivityRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeMaterialSubmitActivityRewardCsReq> _parser = new MessageParser<TakeMaterialSubmitActivityRewardCsReq>(() => new TakeMaterialSubmitActivityRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KAPGHPNEOEKFieldNumber = 9;

	private uint kAPGHPNEOEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeMaterialSubmitActivityRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeMaterialSubmitActivityRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KAPGHPNEOEK
	{
		get
		{
			return kAPGHPNEOEK_;
		}
		set
		{
			kAPGHPNEOEK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMaterialSubmitActivityRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMaterialSubmitActivityRewardCsReq(TakeMaterialSubmitActivityRewardCsReq other)
		: this()
	{
		kAPGHPNEOEK_ = other.kAPGHPNEOEK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeMaterialSubmitActivityRewardCsReq Clone()
	{
		return new TakeMaterialSubmitActivityRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeMaterialSubmitActivityRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeMaterialSubmitActivityRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KAPGHPNEOEK != other.KAPGHPNEOEK)
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
		if (KAPGHPNEOEK != 0)
		{
			num ^= KAPGHPNEOEK.GetHashCode();
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
		if (KAPGHPNEOEK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(KAPGHPNEOEK);
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
		if (KAPGHPNEOEK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KAPGHPNEOEK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeMaterialSubmitActivityRewardCsReq other)
	{
		if (other != null)
		{
			if (other.KAPGHPNEOEK != 0)
			{
				KAPGHPNEOEK = other.KAPGHPNEOEK;
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
			if (num != 72)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KAPGHPNEOEK = input.ReadUInt32();
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OLDMKCIINGH : IMessage<OLDMKCIINGH>, IMessage, IEquatable<OLDMKCIINGH>, IDeepCloneable<OLDMKCIINGH>, IBufferMessage
{
	private static readonly MessageParser<OLDMKCIINGH> _parser = new MessageParser<OLDMKCIINGH>(() => new OLDMKCIINGH());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int MOHHIJGHPNBFieldNumber = 8;

	private uint mOHHIJGHPNB_;

	public const int JOGFDBPAMDPFieldNumber = 11;

	private PEEDNOBMBNN jOGFDBPAMDP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OLDMKCIINGH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OLDMKCIINGHReflection.Descriptor.MessageTypes[0];

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
	public uint MOHHIJGHPNB
	{
		get
		{
			return mOHHIJGHPNB_;
		}
		set
		{
			mOHHIJGHPNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PEEDNOBMBNN JOGFDBPAMDP
	{
		get
		{
			return jOGFDBPAMDP_;
		}
		set
		{
			jOGFDBPAMDP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLDMKCIINGH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLDMKCIINGH(OLDMKCIINGH other)
		: this()
	{
		retcode_ = other.retcode_;
		mOHHIJGHPNB_ = other.mOHHIJGHPNB_;
		jOGFDBPAMDP_ = ((other.jOGFDBPAMDP_ != null) ? other.jOGFDBPAMDP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLDMKCIINGH Clone()
	{
		return new OLDMKCIINGH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OLDMKCIINGH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OLDMKCIINGH other)
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
		if (MOHHIJGHPNB != other.MOHHIJGHPNB)
		{
			return false;
		}
		if (!object.Equals(JOGFDBPAMDP, other.JOGFDBPAMDP))
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
		if (MOHHIJGHPNB != 0)
		{
			num ^= MOHHIJGHPNB.GetHashCode();
		}
		if (jOGFDBPAMDP_ != null)
		{
			num ^= JOGFDBPAMDP.GetHashCode();
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
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (MOHHIJGHPNB != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MOHHIJGHPNB);
		}
		if (jOGFDBPAMDP_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(JOGFDBPAMDP);
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
		if (MOHHIJGHPNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOHHIJGHPNB);
		}
		if (jOGFDBPAMDP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JOGFDBPAMDP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OLDMKCIINGH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.MOHHIJGHPNB != 0)
		{
			MOHHIJGHPNB = other.MOHHIJGHPNB;
		}
		if (other.jOGFDBPAMDP_ != null)
		{
			if (jOGFDBPAMDP_ == null)
			{
				JOGFDBPAMDP = new PEEDNOBMBNN();
			}
			JOGFDBPAMDP.MergeFrom(other.JOGFDBPAMDP);
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
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				MOHHIJGHPNB = input.ReadUInt32();
				break;
			case 90u:
				if (jOGFDBPAMDP_ == null)
				{
					JOGFDBPAMDP = new PEEDNOBMBNN();
				}
				input.ReadMessage(JOGFDBPAMDP);
				break;
			}
		}
	}
}

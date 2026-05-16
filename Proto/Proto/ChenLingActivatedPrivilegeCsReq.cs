using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChenLingActivatedPrivilegeCsReq : IMessage<ChenLingActivatedPrivilegeCsReq>, IMessage, IEquatable<ChenLingActivatedPrivilegeCsReq>, IDeepCloneable<ChenLingActivatedPrivilegeCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChenLingActivatedPrivilegeCsReq> _parser = new MessageParser<ChenLingActivatedPrivilegeCsReq>(() => new ChenLingActivatedPrivilegeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HCEOMBKCDDMFieldNumber = 12;

	private uint hCEOMBKCDDM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChenLingActivatedPrivilegeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChenLingActivatedPrivilegeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCEOMBKCDDM
	{
		get
		{
			return hCEOMBKCDDM_;
		}
		set
		{
			hCEOMBKCDDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingActivatedPrivilegeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingActivatedPrivilegeCsReq(ChenLingActivatedPrivilegeCsReq other)
		: this()
	{
		hCEOMBKCDDM_ = other.hCEOMBKCDDM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingActivatedPrivilegeCsReq Clone()
	{
		return new ChenLingActivatedPrivilegeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChenLingActivatedPrivilegeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChenLingActivatedPrivilegeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HCEOMBKCDDM != other.HCEOMBKCDDM)
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
		if (HCEOMBKCDDM != 0)
		{
			num ^= HCEOMBKCDDM.GetHashCode();
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
		if (HCEOMBKCDDM != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(HCEOMBKCDDM);
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
		if (HCEOMBKCDDM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCEOMBKCDDM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChenLingActivatedPrivilegeCsReq other)
	{
		if (other != null)
		{
			if (other.HCEOMBKCDDM != 0)
			{
				HCEOMBKCDDM = other.HCEOMBKCDDM;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				HCEOMBKCDDM = input.ReadUInt32();
			}
		}
	}
}
